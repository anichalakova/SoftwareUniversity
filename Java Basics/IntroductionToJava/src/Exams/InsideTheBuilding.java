package Exams;

import java.util.Scanner;

public class InsideTheBuilding {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int h = input.nextInt();
		
		int x1 = input.nextInt();
		int y1 = input.nextInt();
		int x2 = input.nextInt();
		int y2 = input.nextInt();
		int x3 = input.nextInt();
		int y3 = input.nextInt();
		int x4 = input.nextInt();
		int y4 = input.nextInt();
		int x5 = input.nextInt();
		int y5 = input.nextInt();
		
		System.out.println(isInsideBuilding(x1, y1, h));
		System.out.println(isInsideBuilding(x2, y2, h));
		System.out.println(isInsideBuilding(x3, y3, h));
		System.out.println(isInsideBuilding(x4, y4, h));
		System.out.println(isInsideBuilding(x5, y5, h));
	}
	public static String isInsideBuilding(int x, int y, int h) {
	
		String isInside;
		if (x < h * 3 && x > 0) {
			if (y < h) {
				isInside = "It is inside the building";
				return isInside;
			}
			else if  (y > h && y < h * 4) {
				if (x > h && x < h * 2) {
					isInside = "it is inside the building";
					return isInside;
				}
				else {
					isInside = "It is NOT inside the building";
					return isInside;
				}
			}
			else {
				isInside = "It is NOT inside the building";
				return isInside;
			}
		}
		else {
			isInside = "It is NOT inside the building";
			return isInside;
		}
		
	}

}
