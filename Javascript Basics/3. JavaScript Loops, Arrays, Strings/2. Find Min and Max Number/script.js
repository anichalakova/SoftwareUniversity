function findMinMax(arr) {
	var min = arr[0];
	var max = arr[0];

	for (var i = 0; i < arr.length; i++) {
		if (arr[i] < min) {
			min = arr[i];
		}
		if (arr[i] > max) {
			max = arr[i];
		}
	}

	console.log(min);
	console.log(max);
}

console.log(findMinMax([1, 2, 1, 15, 20, 5, 7, 31]));