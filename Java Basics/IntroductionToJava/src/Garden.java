import java.util.Scanner;


public class Garden {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int tomatoSeeds = input.nextInt();
		int tomatoArea = input.nextInt();
		int cucumberSeeds = input.nextInt();
		int cucumberArea = input.nextInt();
		int potatoSeeds = input.nextInt();
		int potatoArea = input.nextInt();
		int carrotSeeds = input.nextInt();
		int carrotArea = input.nextInt();
		int cabbageSeeds = input.nextInt();
		int cabbageArea = input.nextInt();
		int beansSeeds = input.nextInt();
		
		int areaLeft = 250 - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);
		double totalCost = (tomatoSeeds * 0.5) + (cucumberSeeds * 0.4) + (carrotSeeds * 0.6) + (cabbageSeeds * 0.3) +
				(potatoSeeds * 0.25) + (beansSeeds * 0.4);
		
		System.out.printf("%.2f", totalCost);
		if (areaLeft > 0) {
			System.out.println("Yes");
			System.out.println(areaLeft);
		}
		else if (areaLeft == 0) {
			System.out.println("No");
		}
		else if (areaLeft < 0) {
			System.out.println("Insufficient area");
		}
	}

}
