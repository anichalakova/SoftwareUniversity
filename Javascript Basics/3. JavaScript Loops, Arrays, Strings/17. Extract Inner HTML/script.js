function extractInner(str) {
	var paragraph = document.createElement("P");
	var parText = document.createTextNode("Hello");
	paragraph.appendChild(parText);
	var anchor = document.createElement("A");
	var aText = document.createTextNode("W3C");
	anchor.appendChild(aText);
	anchor.href = "some link here";
	paragraph.appendChild(anchor);
	console.log(paragraph);
}

extractInner();