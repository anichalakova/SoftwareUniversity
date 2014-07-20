function findLastDigit(arr) {
	var num = arr[0];
	var n = num % 10;

	if (n < 0) {
		n = n * -1;
	}
	
	switch(n) {
		case 1: return "One"; break;
		case 2: return "Two"; break;
		case 3: return "Three"; break;
		case 4: return "Four"; break;
		case 5: return "Five"; break;
		case 6: return "Six"; break;
		case 7: return "Seven"; break;
		case 8: return "Eight"; break;
		case 9: return "Nine"; break;
		case 0: return "Zero"; break;
	}
}

console.log(findLastDigit([6]));
console.log(findLastDigit([-55]));
console.log(findLastDigit([133]));
console.log(findLastDigit([14567]));