


function Ticket(ghe, gia, thoigian) {
    this.ghe = ghe;
    this.gia = gia;
    this.thoigian = thoigian;
}
var tickets = [];

function datve(id) {
    let check = 1;
        tickets.forEach((data) => {
            console.log("id", id);
            if (data.ghe == id) {
                document.getElementById(`box${id}`).style.color = "black";
                tickets = tickets.filter(item => item != data);
                console.log(tickets);
                check = 0;
                return;
            }
        })

    setTimeout(() => {
        if (check == 1) {
            let ticket = new Ticket(id, 1100000, "14/4/2021 6:30");
            tickets = [...tickets, ticket];
            document.getElementById(`box${id}`).style.color = "red";
            document.getElementById("content").innerHTML += `<span> SE8- Sài Gòn- Hà Nội- ngày ${ticket.thoigian} chỗ ngồi ${id} giá ${ticket.gia}</span><br>`
        }
    },100)

}

