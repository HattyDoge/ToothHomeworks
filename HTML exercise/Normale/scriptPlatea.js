//Es Platea
var selectedSeats = [];
var ticketNumber = 0;

function GenerateTable() {
	var rows = 5;
	var columns = 6;
	var seatNumber = 1;
	const tableContainer = document.getElementById("tableContainer");
	const table = document.createElement("table");
	for (var i = 1; i < rows + 1; i++) {
		const row = document.createElement("tr");
		for (var j = 0; j < columns; j++) {
			const cell = document.createElement("td");
			if (j == 5) {
				cell.innerHTML = "fila " + i;
			} else {
				cell.innerHTML = seatNumber++;
			}
			cell.style.textAlign = "center";
			cell.style.userSelect = "none";
			cell.style.width = "100px";
			cell.style.height = "50px";
			cell.style.border = "1px solid black";
			cell.style.backgroundColor = "White";
			cell.addEventListener("click", function () {
				if (!cell.innerHTML.includes("fila")) {
					if (this.style.backgroundColor != "lightcoral")
						if (this.style.backgroundColor == "white") {
							this.style.backgroundColor = "lightGreen";
							selectedSeats.push(
								"Posto " +
									this.innerHTML +
									" fila " +
									Math.floor(this.innerHTML / 5 + 1)
							);
						} else {
							this.style.backgroundColor = "white";

							//INSERT HERE
							selectedSeats.remove(
								"Posto " +
									this.innerHTML +
									" fila " +
									Math.floor(this.innerHTML / 5 + 1)
							);
						}
				}
				PrintSelectedSeats();
			});
			row.appendChild(cell);
		}
		table.appendChild(row);
	}
	tableContainer.appendChild(table);
}

function PrintSelectedSeats() {
	var output = "";
	selectedSeats.forEach((element) => {
		output += element + "<br>";
	});
	document.getElementById("seats").innerHTML = output;
}


function BookSeats() {
	document.getElementById("ticketNumber").textContent = "Numero biglietti venduti: " + selectedSeats.length;
	const celle = document.getElementsByTagName("td");

	for (var i = 0; i < celle.length; i++) {
		if (celle[i].style.backgroundColor == "lightgreen") {
			celle[i].style.backgroundColor = "lightcoral";
		}
	}
}