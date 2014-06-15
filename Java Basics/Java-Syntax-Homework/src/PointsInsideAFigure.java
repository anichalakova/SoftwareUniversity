import java.util.Scanner;


public class PointsInsideAFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		
		if (x >= 12.5 && x <= 22.5) {
			if (y >= 6 && y <= 8.5) {
				System.out.println("Inside");
			}
			else if (x >= 12.5 && x <= 17.5) {
				if (y >= 6 && y <= 13.5) {
					System.out.println("Inside");
				}
				else {
					System.out.println("Outside");
				}
			}
			else if (x >= 20 && x <= 22.5) {
				if (y >= 6 && y <= 13.5) {
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
		else if (x < 12.5 || x > 22.5) {
			System.out.println("Outside");
		}

	}

}
