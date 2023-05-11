//סלקט של יצרנים

function getAllproductToSelect1() {
    var path = 'https://localhost:44399/api/'
    axios.get(path + 'product/Get').then(
        (response) => {
            console.log(response)
            var result = response.data;
            Setproduct(result)
            console.log(result);
        },
        (error) => {
            console.log(error);
        }
    );
}


// ללא משתנה שתוצג תיבה לבחירת מוצר
function Setproduct(e) {
    sel = document.getElementById("idproduct")
    for (var i = 0; i < e.length; i++) {
        opt = document.createElement('option')
        opt.text = e[i].name_product
        opt.value = e[i].id_product
        sel.appendChild(opt)
    }
}

//הוספת יצרן
function addproducttbl(path) {
    var name = document.getElementById("product_name").value;
    var queryObj = { name_product: name };

    axios.post(path, queryObj).then(
        (response) => {
            var result = response.data;

            if (result) {
                alert("היצרן נוסף בהצלחה");
            }
            console.log(result);

        },
        (error) => {
            console.log(error);
        }
    );
}
