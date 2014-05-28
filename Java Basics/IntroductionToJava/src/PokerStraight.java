import java.util.Scanner;


public class PokerStraight {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int weight = input.nextInt();
		int count = 0;
		
		String[] faces = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
		String[] suits = {"Clubs", "Diamonds", "Hearts", "Spades"};
		
		for (int face = 0; face < faces.length - 4; face++) {
			for (int suits1 = 0; suits1 < suits.length; suits1++) {
				for (int suits2 = 0; suits2 < suits.length; suits2++) {
					for (int suits3 = 0; suits3 < suits.length; suits3++) {
						for (int suits4 = 0; suits4 < suits.length; suits4++) {
							for (int suits5 = 0; suits5 < suits.length; suits5++) {
								int stringWeight = 
									(face + 1) * 10 + suits1 + 1 +
									(face + 2) * 20 + suits2 + 1 +
									(face + 3) * 30 + suits3 + 1 +
									(face + 4) * 40 + suits4 + 1 + 
									(face + 5) * 50 + suits5 + 1;
								
								if (weight == stringWeight) {
									count++;
								}
							}
						}
					}
				}
			}
		}
		System.out.println(count);
	}

}
