
//הוספת עיר
function addcitytbl(path) {
    var name = document.getElementById("cityname").value;
    var queryObj = { city_name: name };

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

//מחיקת עיר
function removcity() {
    
    var pid = document.getElementById("ccid").value;
   
    var h = parseInt(pid);
    axios.delete('https://localhost:44399/api/city/Delete/'+h).then(
        (response) => {
            var result = response.data;
            if (result) {
                alert("העיר נמחקה");
            }
            console.log(result);

        },
        (error) => {
            console.log(error);
        }
    );

}







//יצירת טבלת ערים

var path = 'https://localhost:44399/api/'
function GetCity() {
    axios.get(path + 'city/Get').then(
        (response) => {
            console.log(response)
            var result = response.data;


            var body = document.getElementsByClassName("bodyb")[0];
            var table = document.createElement("table");
            table.className = "table table-hover MyTable ";


            var thead = document.createElement("thead");
            var tr = document.createElement("tr");
            var th = document.createElement("th");

            th.innerHTML = 'קוד עיר';

            tr.appendChild(th);
            th = document.createElement("th");
            th.innerHTML = 'שם עיר';

            tr.appendChild(th);
            th = document.createElement("th");

            tr.appendChild(th);

            thead.appendChild(tr);
            table.appendChild(thead);

            var tbody = document.createElement("tbody");
            for (var i = 0; i < result.length; i++) {
                var tr = document.createElement("tr");

                var td = document.createElement("td");
                td.innerHTML = result[i].id_city;
                tr.appendChild(td);

                var td = document.createElement("td");
                td.innerHTML = result[i].city_name;
                tr.appendChild(td);


                tr.appendChild(td);

                tbody.appendChild(tr);

            }

            table.appendChild(tbody);
            body.appendChild(table);


        },
        (error) => {
            console.log(error);
        }
    );
}
//סלקט של ערים

function getAllcityToSelect() {
    var path = 'https://localhost:44399/api/'
    axios.get(path + 'city/Get').then(
        (response) => {
            console.log(response)
            var result = response.data;
            Setcity(result)
            console.log(result);
        },
        (error) => {
            console.log(error);
        }
    );
}
function deleatcity() {
    var del = document.getElementById("delaetecity");
    if (del.style.display == "none")
        del.style.display = "block";
    else
        del.style.display = "none";
}
