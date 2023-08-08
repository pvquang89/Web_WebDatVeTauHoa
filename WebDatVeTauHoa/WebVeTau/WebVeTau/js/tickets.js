

$(function () {
    getTickets();
    mydate();
    checkRadio();
    checkSelect();
 });

function Tickets(maChuyen, gia = [], thoigian) {
    this.maChuyen = maChuyen;
    this.gia = gia;
    this.thoigian = thoigian;
}
var tickets = [];

function getTickets() {

    tickets = [
        new Tickets("SE6", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm"),
        new Tickets("SE7", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm"),
        new Tickets("SE8", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm"),
        new Tickets("SE4", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm"),
        new Tickets("TN3", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm"),
        new Tickets("TN2", ["Ngồi Cứng: liên hệ", "Ngồi Cứng Điều Hòa: 450000 đ", "Ngồi Mềm: liên hệ", "Ngồi Mềm Điều Hòa: 690000 đ", "Nằm Cứng Điều Hòa: 920000 đ", "Nằm Mềm Điều Hòa: 960000 đ"], "06:00am - 15:33pm")
    ]
    
    fillTicketsToTable(tickets);
}

function fillGia(item) {
    let html2 = "";
    item.forEach((data) => {
        html2 +=
            '<ul>' +
            '<li>' + data + '</li>' +
            '</ul>'

    });
    return html2;
}

function fillTicketsToTable(tickets) {
    var html = "";
    tickets.forEach((data) => {
        html +=
            '<tr>' +
            '<td>' + data.maChuyen + '<br>' + '<a href="#detail-inf">Đặt vé</a>' + '</td>' +
            '<td>' + fillGia(data.gia) + '</td>' +
            '<td style="color:red;"> <u>' + data.thoigian + '</u></td>' +
            '</tr>'
    })
    document.getElementById("tbody").innerHTML = html;
}

function mydate() {
    document.getElementById("ngaydi").valueAsDate = new Date();
    document.getElementById("ngayve").valueAsDate = new Date();
}

function checkRadio() {
    if (document.getElementById("rdo-inf-1").checked) {
        document.getElementById("ngayve-layer").style.display = "none";
    } else {
        document.getElementById("ngayve-layer").style.display = "block";
    }
}

function checkSelect() {
    var id = document.getElementById('sl2').value;
    if (document.getElementById('sl1').value == document.getElementById('sl2').value) {
        document.getElementById('sl2').value = ++id;
    }
}