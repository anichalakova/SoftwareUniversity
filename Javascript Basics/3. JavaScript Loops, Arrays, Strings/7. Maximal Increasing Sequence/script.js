function longestSequence (arr) {

	var tempLength = 1;
	var length = 1;
	var lastIndex = 0;

	for (var i = 1; i < arr.length; i++) {
		if (arr[i] > arr[i - 1]) {
			tempLength++;
			index = arr[i];
			if (tempLength > length) {
				length = tempLength
				lastIndex = i	
			}
		}
		else {
			tempLength = 0;
		}
	}

	

}

console.log(longestSequence([3, 2, 3, 4, 2, 2, 4]));