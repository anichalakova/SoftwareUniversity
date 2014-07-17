function supplyCalc (age, maxAge, amount) {
	var time = (maxAge - age) * 365;
	var estimated = time * amount;
	return estimated;
}
console.log(supplyCalc(38, 118, 0.5) + "kg");
console.log(supplyCalc(20, 87, 2) + "kg");
console.log(supplyCalc(16, 102, 1.1) + "kg");