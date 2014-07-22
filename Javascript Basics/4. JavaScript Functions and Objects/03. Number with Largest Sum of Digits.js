function findNumWithLargestSum(arr) {
	var sum = 0;
	var tempSum = 0;
	var element;

	var insuffCount = 0;

	for (var i = 0; i < arr.length; i++) {
		if (arr[i] < 10) {
			insuffCount++;
		}
		arr[i] = removeNonDigit(arr[i]);
	}

	if (insuffCount === arr.length) {
		return "undefined";
	}

	for (var i = 0; i < arr.length; i++) {
		tempSum = 0;
		findSum(arr[i]);
		if (tempSum > sum) {
			sum = tempSum;
			element = arr[i];
		}
	}

	return element;

	function findSum (num) {
		while (num > 0) {
			tempSum += num % 10;
			num = parseInt(num / 10);
		}
	}
	function removeNonDigit (num) {
		num = num.toString();
		num = num.replace(/\D/g,'');
		num = parseInt(num);
		return num;
	}
}

console.log(findNumWithLargestSum([5, 10, 15, 111]));
console.log(findNumWithLargestSum([33, 44, -99, 0, 20]));
console.log(findNumWithLargestSum([5, 3.3]));
console.log(findNumWithLargestSum(['hello']));