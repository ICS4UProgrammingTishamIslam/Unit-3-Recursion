/*
 * Created by: Tisham Islam
 * Created on: 11/06/2019
 * Created for: ICS4U
 * Day #26 (Factorial!)
 * This program calculates a number factorialized using the power of recursion
*/

import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.Shell;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.Spinner;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;

public class Factorial {

	protected Shell shlFactorial;

	/**
	 * Launch the application.
	 * @param args
	 */
	public static void main(String[] args) {
		try {
			Factorial window = new Factorial();
			window.open();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	/**
	 * Open the window.
	 */
	public void open() {
		Display display = Display.getDefault();
		createContents();
		shlFactorial.open();
		shlFactorial.layout();
		while (!shlFactorial.isDisposed()) {
			if (!display.readAndDispatch()) {
				display.sleep();
			}
		}
	}

	/**
	 * Create contents of the window.
	 */
	protected void createContents() {
		shlFactorial = new Shell();
		shlFactorial.setSize(450, 300);
		shlFactorial.setText("Factorial By Tisham Islam");

		Spinner spnFactorial = new Spinner(shlFactorial, SWT.BORDER);
		spnFactorial.setMaximum(20);
		spnFactorial.setBounds(196, 84, 47, 22);
		
		Label lblFactorial = new Label(shlFactorial, SWT.NONE);
		lblFactorial.setBounds(22, 132, 232, 53);
		lblFactorial.setText("Result will appear here\r\nNumbers after !20 get an integer overflow,\r\n"
				+ "even while using a larger capacity variable");		
		
		Button btnCalculate = new Button(shlFactorial, SWT.NONE);
		btnCalculate.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent e) {
				//display the results  using the spinner's selection
				lblFactorial.setText("!" + spnFactorial.getSelection() + " is equal to: " + TFactorial(spnFactorial.getSelection()));
			}
		});
		btnCalculate.setBounds(22, 81, 75, 25);
		btnCalculate.setText("CALCULATE");

	}
	
	//my factorial function
	public long TFactorial(long n) {
		//base case, return one at the end of the function. also, !0 = zero
		if (n == 1 || n == 0) {
			return 1;		
		}
		else {
			//return the previous value in the factorial function multiplied by n
			return n * TFactorial(n-1);
		}
	}
}
