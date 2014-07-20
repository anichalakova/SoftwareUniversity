function findDigit(arr) {
	var number = arr[1];
	var n = arr[0];

	number = number.toString();
	number = number.replace(/\D/g,'');
	if (number.length < n) {
		return "The number doesn't have " + n + " digits";
	}
	number = parseInt(number);

	for (var i = 0; i < n; i++) {
		var digit = number % 10;
		number = parseInt(number / 10);
	}

	if (digit < 0) {
		digit = digit * -1;
	}
	
	switch(digit) {
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

console.log(findDigit([1, 6]));
console.log(findDigit([2, -55]));
console.log(findDigit([6, 923456]));
console.log(findDigit([3, 1451.78]));
console.log(findDigit([6, 888.88]));