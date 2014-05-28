import java.util.Scanner;


public class FiveSpecialLetters {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int start = in.nextInt();
		int end = in.nextInt();
		
		int count = 0;
		
		for (char c1 = 'a'; c1 <= 'e'; c1++) {
			for (char c2 = 'a'; c2 <= 'e'; c2++) {
				for (char c3 = 'a'; c3 <= 'e'; c3++) {
					for (char c4 = 'a'; c4 <= 'e'; c4++) {
						for (char c5 = 'a'; c5 <= 'e'; c5++) {
							String word = "" + c1 + c2 + c3 + c4 + c5;
							long weight = calculateWeight(word);
							if (weight >= start && weight <= end) {
								System.out.println(word + " ");
							}
						}
					}
				}
			}
		}
		
	}
	public static int generateWeight (char letter) {
		switch (letter) {
		case 'a': return 5;
		case 'b': return - 12;
		case 'c': return 47;
		case 'd': return 7;
		case 'e': return -32;
		}
		return 0;
	}
	
	public static long calculateWeight (String word) { 
		boolean[] visited = new boolean[(int)'e' + 1];
		long weight = 0;
		int index = 1;
		for (int i = 0; i < word.length(); i++) {
			char letter = word.charAt(i);
			
			if (!visited[letter]) {
				weight += index * generateWeight(letter);
				visited[letter] = true;
				index++;
			}
		}
		return weight;
	}

}