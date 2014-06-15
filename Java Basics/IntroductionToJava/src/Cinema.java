import java.util.Scanner;


public class Cinema {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String type = input.next();
		double rows = input.nextDouble();
		double columns = input.nextDouble();
		
		Double viewers = rows * columns;
		if (type.equals("Premiere")) {
			System.out.printf("%.2f leva", viewers * 12.00);
		}
		else if (type.equals("Normal")) {
			System.out.printf("%.2f leva", viewers * 7.5);
		}
		else if (type.equals("Discount")) {
			System.out.printf("%.2f leva", viewers * 5.00);
		}
	}

}
