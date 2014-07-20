function findBigger(arr) {
	var element = arr[0];
	var array = arr[1];

	if (element === 0 || element === array.length - 1) {
		return "only one neighbour"
	}
	else if (element < 0 || element > array.length - 1) {
		return "no such index";
	}


	if (array[element] > array[element + 1] && array[element] > array[element - 1]) {
		return "bigger";
	}
	else {
		return "not bigger";
	}
}

console.log(findBigger([2, [1, 2, 3, 3, 5 ]]));
console.log(findBigger([2, [1, 2, 5, 3, 4 ]]));
console.log(findBigger([5, [1, 2, 5, 3, 4 ]]));
console.log(findBigger([0, [1, 2, 5, 3, 4 ]]));