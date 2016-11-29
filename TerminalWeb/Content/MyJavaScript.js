window.onload = function () {
			var chart = new CanvasJS.Chart("chartContainer", {
				title: {
					text: "Biểu đồ dân số"
				},
				backgroundColor: "#ecf0f1",
				data: [{
					type: "column",
					dataPoints: [
					  { x: 1910, y: 750 },
					  { x: 1920, y: 714 },
					  { x: 1930, y: 320 },
					  { x: 1940, y: 560 },
					  { x: 1950, y: 430 },
					  { x: 1960, y: 500 },
					  { x: 1970, y: 480 },
					  { x: 1980, y: 280 },
					  { x: 1990, y: 410 },
					  { x: 2000, y: 500 },
					]
				}, {
					type: "column",
					dataPoints: [
					  { x: 1910, y: 250 },
					  { x: 1920, y: 414 },
					  { x: 1930, y: 919 },
					  { x: 1940, y: 967 },
					  { x: 1950, y: 678 },
					  { x: 1960, y: 878 },
					  { x: 1970, y: 787 },
					  { x: 1980, y: 780 },
					  { x: 1990, y: 803 },
					  { x: 2000, y: 330 },
					]
				}, {
					type: "column",
					dataPoints: [
					  { x: 1910, y: 400 },
					  { x: 1920, y: 917 },
					  { x: 1930, y: 520 },
					  { x: 1940, y: 804 },
					  { x: 1950, y: 450 },
					  { x: 1960, y: 969 },
					  { x: 1970, y: 380 },
					  { x: 1980, y: 839 },
					  { x: 1990, y: 610 },
					  { x: 2000, y: 850 },
					]
				}]
			});
			chart.render();
	var chartPie = new CanvasJS.Chart("chartContainerPie",
	{
		theme: "theme2",
		title:{
			text: "Gaming Consoles Sold in 2012"
		},
		backgroundColor:"#ecf0f1"		,
		data: [
		{
			type: "pie",
			showInLegend: true,
			toolTipContent: "{y} - #percent %",
			yValueFormatString: "#0.#,,. Million",
			legendText: "{indexLabel}",
			dataPoints: [
				{  y: 4181563, indexLabel: "PlayStation 3" },
				{  y: 2175498, indexLabel: "Wii" },
				{  y: 3125844, indexLabel: "Xbox 360" },
				{  y: 1176121, indexLabel: "Nintendo DS"},
				{  y: 1727161, indexLabel: "PSP" },
				{  y: 4303364, indexLabel: "Nintendo 3DS"},
				{  y: 1717786, indexLabel: "PS Vita"}
			]
		}
		]
	});
	chartPie.render();
	
	var chartLine = new CanvasJS.Chart("chartContainerLine", {
				title: {
					text: "Click on legend items to hide/unhide dataseries"
				},		
		backgroundColor:"#ecf0f1",

				legend: {
					cursor: "pointer",
					itemclick: function (e) {
						if (typeof (e.dataSeries.visible) === "undefined" || e.dataSeries.visible) {
							e.dataSeries.visible = false;
						} else {
							e.dataSeries.visible = true;
						}

						e.chart.render();
					}
				},
				data: [{
					showInLegend: true,
					type: "line",
					dataPoints: [
						{ x: 10, y: 5 },
						{ x: 20, y: 9 },
						{ x: 30, y: 17 },
						{ x: 40, y: 32 },
						{ x: 50, y: 22 },
						{ x: 60, y: 14 },
						{ x: 70, y: 25 },
						{ x: 80, y: 18 },
						{ x: 90, y: 20 }
					]
				}, {
					showInLegend: true,
					type: "line",
					dataPoints: [
						{ x: 10, y: 31 },
						{ x: 20, y: 35 },
						{ x: 30, y: 30 },
						{ x: 40, y: 35 },
						{ x: 50, y: 35 },
						{ x: 60, y: 38 },
						{ x: 70, y: 38 },
						{ x: 80, y: 34 },
						{ x: 90, y: 44 }
					]
				}, {
					showInLegend: true,
					type: "line",
					dataPoints: [
						{ x: 10, y: 25 },
						{ x: 20, y: 30 },
						{ x: 30, y: 20 },
						{ x: 40, y: 45 },
						{ x: 50, y: 30 },
						{ x: 60, y: 10 },
						{ x: 70, y: 15 },
						{ x: 80, y: 18 },
						{ x: 90, y: 20 }
					]
				}]
			});

			chartLine.render();
		var chartGender = new CanvasJS.Chart("chartContainerGender",
			{
				title: {
					text: "Biểu đồ  tỷ lệ sinh tử"
				},
		backgroundColor:"#ecf0f1",

				data: [
				{
					type: "stackedColumn100",
					dataPoints: [
					{ y: 40, label: "Hà Nội" },
					{ y: 10, label: "HCM" },
					{ y: 72, label: "Nam Định" },
					{ y: 30, label: "Hải Phòng" },
					{ y: 21, label: "Đà Nẵng" }
					]
				}, {
					type: "stackedColumn100",
					dataPoints: [
					{ y: 20, label: "Hà Nội" },
					{ y: 14, label: "HCM" },
					{ y: 40, label: "Nam Định" },
					{ y: 43, label: "Hải Phòng" },
					{ y: 17, label: "Đà Nẵng" }
					]
				}

				]
			});

			chartGender.render();
	
}