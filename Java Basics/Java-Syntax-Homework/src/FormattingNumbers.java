import java.util.Scanner;


public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		double b = input.nextDouble();
		double c = input.nextDouble();
		
		String aHexadecimal = Integer.toHexString(a);
        String aBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
        
        if (c%1 == 0) {
            System.out.printf("|%-10s|%s|%10.2f|%-10.0f|",aHexadecimal,aBinary,b,c);
        }
        else {
            System.out.printf("|%-10s|%s|%10.2f|%-10.3f|",aHexadecimal,aBinary,b,c);
        }
	}

}
