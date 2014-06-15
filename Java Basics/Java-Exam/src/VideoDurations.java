import java.util.Scanner;


public class VideoDurations {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String sayEnd = "";
		int minutes = 0;
		int hours = 0;
		String[] lengths = {};
		
		while (!sayEnd.equals("End")) {
			sayEnd = input.nextLine();
			if (sayEnd.equals("End")) {
				break;
			}
			else {
				lengths = sayEnd.split(":");
				int tempHours = Integer.parseInt(lengths[0]);
				int tempMinutes = Integer.parseInt(lengths[1]);
				for (int i = 0; i < tempMinutes; i++) {
					minutes++;
					if (minutes == 60) {
						minutes = 00;
						hours++;
					}
				}
				hours += tempHours;
			}
		}
		
		System.out.printf("%d:%02d", hours, minutes);
		
	}

}
