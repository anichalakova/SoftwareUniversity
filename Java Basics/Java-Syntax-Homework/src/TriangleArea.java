import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int x1 = input.nextInt();
		int y1 = input.nextInt();
		int x2 = input.nextInt();
		int y2 = input.nextInt();
		int x3 = input.nextInt();
		int y3 = input.nextInt();
		
		int area = (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2;
		
		if (area < 0) {
			area = area * -1;
		}
		
		System.out.println(area);
	}

}
