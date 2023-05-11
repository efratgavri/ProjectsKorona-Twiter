

//הוספת לקוח
function addvaccinationtbl(path) {
    var id = document.getElementById("id").value;
   
    var date = document.getElementById("date").value;
    var id_product = document.getElementById("idproduct").value;
    var queryObj = { id_client: id, date_vaccination: date, id_product: id_product };

    axios.post(path, queryObj).then(
        (response) => {
            var result = response.data;

            if (result) {
                alert("לקוח נוסף בהצלחה");
            }
            console.log(result);

        },
        (error) => {
            console.log(error);
        }
    );
}
//כל החיסונים
var path = 'https://localhost:44399/api/'
function Get_vaccination_all() {
    axios.get(path + 'vaccination/Get').then(
        (response) => {
            console.log(response)
            var result = response.data;
            return result
        },
        (error) => {
            console.log(error);
        }
    );
}
var path = 'https://localhost:44399/api/vaccination'

function Getvaccination() {
    var path = 'https://localhost:44399/api/vaccination/Getvaccinationwithproductname_by_id_client/'
    var id = document.getElementById("id_client").value;

    axios.get(path +id ).then(
        (response) => {
            console.log(response)
            var result = response.data;


            var body = document.getElementsByClassName("bodyb")[0];
            var table = document.createElement("table");
            table.className = "table table-hover MyTable ";


            var thead = document.createElement("thead");
            var tr = document.createElement("tr");
            var th = document.createElement("th");

            th.innerHTML = 'תז לקוח';

            tr.appendChild(th);
            th = document.createElement("th");
            th.innerHTML = 'תאריך חיסון';

            tr.appendChild(th);
            th = document.createElement("th");
            th.innerHTML = 'יצרן';

            tr.appendChild(th);
            




            thead.appendChild(tr);
            table.appendChild(thead);

            var tbody = document.createElement("tbody");

            for (var i = 0; i < result.length; i++) {
                tr = document.createElement("tr")
                tr.className = "MyTblTr"
                tr.value = result[i][0]
                //עבור כל עמודה
                for (var j = 0; j < result[i].length; j++) {
                    td = document.createElement("td")
                    td.innerHTML = result[i][j]
                    tr.appendChild(td)
                    tbody.appendChild(tr);
                }
            }

            table.appendChild(tbody);
            body.appendChild(table);


        },
        (error) => {
            console.log(error);
        }
    );
}