function sortArray(arr) {
	var nums = arr.map(Number);

	var min;
	var helper;

	for (var i = 0; i < nums.length; i++) {
		for (var j = i; j < nums.length; j++) {
			if (nums[j] < nums[i]) {
				helper = nums[i];
				nums[i] = nums[j];
				nums[j] = helper;
			}
		}
	}
	return nums;
}

console.log(sortArray([5, 4, 3, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));