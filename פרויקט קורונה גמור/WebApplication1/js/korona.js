

function Getidclient() {
    var id = document.getElementById("id_client" ).value;
    var path = 'https://localhost:44399/api/korona/Getidclient/'
    axios.get(path + id).then(
        (response) => {
            console.log(response)
            var result = response.data;

            if (result == " ") {
                Addnewkorona('https://localhost:44399/api/korona/Post')
            }
            else
                Update_date_vecvery()

        },
        (error) => {

            alert("מוצר זה תפוס")
        }
    );
}


function Update_date_vecvery() {

    var id = document.getElementById("id_client").value;
    var date_vecvery = document.getElementById("date_vecovery").value;
    var queryObj = [id_client = id, date_vecvery = date_vecvery];
    axios.post('https://localhost:44399/api/korona/Update_date_vecvery', queryObj).then(
        (response) => {
            var result = response.data;
            if (result) {
                alert("המייל עודכן בהצלחה");
            }
            console.log(result);

        },
        (error) => {
            console.log(error);
        }
    );

}

//הוספת חולי
function Addnewkorona(path) {
    var id = document.getElementById("id_client").value;
    var date_sick = document.getElementById("date_sick").value;
    var date_vecovery = '00.00.00'
    var queryObj = { id_client: id, date_sick: date_sick, date_vecovery: date_vecovery };

    axios.post(path, queryObj).then(
        (response) => {
            var result = response.data;

            if (result) {
                alert("העיר נוספה בהצלחה");
            }
            console.log(result);

        },
        (error) => {
            console.log(error);
        }
    );
}
function createChart(data) {
    // יצירת מערך התאריכים לציר האופקי (ימים בחודש)
    var labels = [];
    for (var i = 1; i <= data.length; i++) {
        labels.push(i);
    }

    // יצירת הגרף באמצעות Chart.js
    var ctx = document.getElementById('myChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: [{
                label: 'כמות החולים ביום בחודש',
                data: data,
                backgroundColor: 'rgba(0, 123, 255, 0.5)', // צבע רקע הגרף
                borderColor: 'rgba(0, 123, 255, 1)', // צבע קו הגרף
                borderWidth: 1,


            }]
        },
        options: {
            scales: {
                y: {
                    borderWidth: 1,
                    beginAtZero: true,// התחל את ציר האנכי מהערך 0
                    ticks: {
                        stepSize: 1
                    }
                }
            }
        }
    });
}

var path = 'https://localhost:44399/api/'
function Getsick() {
    axios.get(path + 'korona/Get').then(
        (response) => {
            console.log(response)
            var counters = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];
            var today = new Date();
            var result = response.data;
            for (var i = 0; i < result.length; i++) {
                const vecovery_date = new Date(result[i].date_vecovery)
                const sick_date = new Date(result[i].date_sick)
                
                if (today.getFullYear() === sick_date.getFullYear()){
                    if (((today.getMonth() - 1) === sick_date.getMonth()) && (((today.getMonth()) - 1) === vecovery_date.getMonth()))
                        for (var j = sick_date.getDate(); j < (vecovery_date.getDate() + 1); j++)
                            counters[j-1]+=1;
                    else
                        if (((today.getMonth()) - 1) === sick_date.getMonth())
                            for (var j = sick_date.getDate(); j < 30; j++)
                                counters[j-1]+=1;
                    else
                            if (((today.getMonth()) - 1) === vecovery_date.getMonth())
                             for (var j = 0; j < vecovery_date.getDate(); j++)
                                counters[j-1]+=1;
                }
              
            }
            createChart(counters)
          
        },
        (error) => {
            console.log(error);
        }
    );
}




