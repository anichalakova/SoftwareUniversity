public class FullHouse {

	public static void main(String[] args) {
		String[] cards = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
		char[] suits = {'♣', '♦', '♥', '♠'};
		int count = 0;
		
		for (int i = 0; i < cards.length; i++) { 
			for (int j = 0; j < cards.length; j++) { 
				for (int j2 = 0; j2 < suits.length; j2++) { 
					for (int k = j2 + 1; k < suits.length; k++) { 
						for (int k2 = k + 1; k2 < suits.length; k2++) {																		
							for (int l = 0; l < suits.length; l++) {
								for (int l2 = l + 1; l2 < suits.length; l2++) {
									if (i != j) {
										System.out.printf(
												"%s%c %s%c %s%c %s%c %s%c\n",
												cards[i], suits[j2], cards[i],
												suits[k], cards[i], suits[k2],
												cards[j], suits[l], cards[j],
												suits[l2]);
										count++;
									}

								}

							}

						}
					}
				}
			}
		}
		System.out.print(count + " full houses");
	}

}
