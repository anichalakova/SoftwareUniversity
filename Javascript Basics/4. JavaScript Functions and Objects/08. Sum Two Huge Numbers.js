function sumHugeNumbers(arr) {
	var nums = arr.map(Number);
	sum = nums[0] + nums[1];
	return sum;
}

console.log(sumHugeNumbers(['123456789', '123456789']));
console.log(sumHugeNumbers(['887987345974539','4582796427862587']));
console.log(sumHugeNumbers(['347135713985789531798031509832579382573195807',
 							'817651358763158761358796358971685973163314321']));		