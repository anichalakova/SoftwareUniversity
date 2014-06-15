import java.util.Scanner;


public class NewHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int n = input.nextInt();
		int symbolsBefore = (n - 1) / 2;
		int roof = 1;
		
		for (int i = 0; i < (n / 2) + 1; i++) {
			String dashes = new String(new char[symbolsBefore]).replace("\0", "-");
			String stars = new String(new char[roof]).replace("\0", "*");
			String dots = new String(new char[symbolsBefore]).replace("\0", "-");
			System.out.printf("%s%s%s", dashes, stars, dashes);
            System.out.println();
            symbolsBefore --;
            roof += 2;
		}
		
		for (int i = 0; i < n; i++) {
			System.out.print('|');
			String dots = new String(new char[n - 2]).replace("\0", "*");
			System.out.print(dots);
			System.out.println('|');
		}
		
		input.close();
	}

}
