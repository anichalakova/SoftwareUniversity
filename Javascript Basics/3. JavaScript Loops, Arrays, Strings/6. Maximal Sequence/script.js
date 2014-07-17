function longestSequence (arr) {

	var tempLength = 0;
	var length = 0;

	for (var i = 1; i < arr.length; i++) {
		if (arr[i] == arr[i - 1]) {
			tempLength++;
			index = arr[i];
			if (tempLength > length) {
				length = tempLength
			}
		}
		else {
			tempLength = 0;
		}
	}

	var sequence = [];
	for (var i = 0; i <= length; i++) {
		sequence[i] = index;
	}

	return sequence;
}

console.log(longestSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(longestSequence([2, 'qwe', 'qwe', 3, 3, '3']));