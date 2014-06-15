import java.util.Random;


public class RandomHandsOfFiveCards {

	public static void main(String[] args) {
		String[] cards = new String[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] suits = {"♣", "♦", "♥", "♠"};
		String random = (cards[new Random().nextInt(cards.length)]);
		
		createCard(cards, suits);

	}
	private static void createCard(String[] cards, String[] suits) {
		int similarity = 0;
		String[] sampleHand = new String[5];
		String[] randomSuits = new String[5];
		
		for (int i = 0; i < 5; i++) {
			String random = (cards[new Random().nextInt(cards.length)]);
			sampleHand[i] = random;
		}
		for (int i = 0; i < 5; i++) {
			String random = (suits[new Random().nextInt(suits.length)]);
			randomSuits[i] = random;
		}
		
		for (int i = 0; i < 5; i++) {
			System.out.print(sampleHand[i] + " ");
			System.out.println(randomSuits[i]);
		}
	}

}
