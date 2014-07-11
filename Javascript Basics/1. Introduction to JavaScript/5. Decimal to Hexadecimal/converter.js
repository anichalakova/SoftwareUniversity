function getDecimal() {
	var decimal = prompt("Please insert decimal number");
	decimal = parseFloat(decimal);
	console.log(decimal);
	hexString = decimal.toString(16).toUpperCase();
	alert(hexString);
}
getDecimal();