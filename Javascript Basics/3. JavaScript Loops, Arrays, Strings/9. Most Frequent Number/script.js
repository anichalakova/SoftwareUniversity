function mostFrequent(arr) {
	var numbers = arr.map(Number);

	var tempCount = 0;
	var count = 0;
	var longest;

	for (var i = 0; i < numbers.length; i++) {
		tempCount = 0;
		for (var j = 0; j < numbers.length; j++) {
			if (numbers[i] == numbers[j]) {
				tempCount++;
				if (tempCount > count) {
					count = tempCount;
					longest = arr[i];
				}
			}
		}
	}
	return longest + '(' + count + 'times' + ')';
}

console.log(mostFrequent([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));