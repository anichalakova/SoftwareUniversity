import java.util.Scanner;


public class PointInsideAHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double X = input.nextDouble();
		double Y = input.nextDouble();
		
		boolean bottomLine = ((17.5 - 12.5)*(Y - 8.5) - (8.5 - 8.5)*(X - 12.5)) > 0;
		boolean leftLine = ((17.5 - 12.5)*(Y - 8.5) - (3.5 - 8.5)*(X - 12.5)) > 0;
		boolean rightLine = ((22.5 - 17.5)*(Y - 3.5) - (8.5 - 3.5)*(X - 17.5)) > 0;

		if (X >= 12.5 && X <= 22.5 && Y >= 3.5 && Y <= 13.5){
			if (X >= 12.5 && X <= 17.5) {
				if (Y >= 8.5 && Y <= 13.5) {
					System.out.println("Inside");
				}
				else {
					System.out.println("Outside");
				}
			}
			else if (X >= 20.5 && X <= 22.5) {
					if (Y >= 8.5 && Y <= 13.5) {
						System.out.println("Inside");
					}
					else {
						System.out.println("Outside");
					}
			}
			else {
				System.out.println("Outside");
			}
		}
		else if (bottomLine == false && leftLine == true && rightLine == true) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside ");
		}
	}

}
