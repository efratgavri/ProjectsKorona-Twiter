

//var customers =[
//    {
//        idcust: 1,
//        firstname: "efrat",
//        lastname: "gavriel",
//        phon: "039095169",
//        mail: "e02502@gmail.com",
//        address: "המאירי",
//        idcity:2
//    } ,
    
//     {
//        idcust: 1,
//        firstname: "efi",
//        lastname: "gabi",
//        phon: "03909522",
//        mail: "e02@gmail.com",
//        address: "הריף",
//        idcity:1
//    } ,
     
//      {
//        idcust: 1,
//        firstname: "efratush",
//        lastname: "gavrielush",
//        phon: "038085169",
//        mail: "e0250882@gmail.com",
//        address: "הרמבם",
//        idcity: 3
//    }        
//]
////יצירת טבלת לקוחות אצל המשתמש
//function CreatecustTbl()
//{

//    var myDiv = document.getElementById("getcust")
//    var TheTable = document.createElement("table")

//    TheTable.style.backgroundColor = "#ff00"
//    TheTable.style.border = "4px solid red"
//    myDiv.appendChild(TheTable);
//    var TheTr = document.createElement("tr")
//    var TheTh = document.createElement("th")

//    TheTh.innerHTML = "קוד לקוח"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)


//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "שם פרטי"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)

//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "שם משפחה"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)

//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "טלפון"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)

//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "מייל"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)

//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "כתובת"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)


//    TheTh = document.createElement("th")
//    TheTh.innerHTML = "קוד עיר"
//    TheTh.style.padding = "7px";
//    TheTh.style.border = "1px solid blue";
//    TheTr.appendChild(TheTh)

//    TheTable.appendChild(TheTr)

//    var TheTd;
//    for (var i = 0; i < customers.length; i++) {
//        TheTr = document.createElement("tr")
//            TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].idcust
//        TheTr.appendChild(TheTd)


//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].firstname
//        TheTr.appendChild(TheTd)



//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].lastname
//        TheTr.appendChild(TheTd)


//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].phon
//        TheTr.appendChild(TheTd)

//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].mail
//        TheTr.appendChild(TheTd)

//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].address
//        TheTr.appendChild(TheTd)

//        TheTd = document.createElement("td")
//        TheTd.innerHTML = customers[i].idcity
//        TheTr.appendChild(TheTd)


//        TheTable.appendChild(TheTr)
//    }

   
  
//}
////function sarch(string tav) {
////    for (var i = 0; i < customers.length; i++) {
////        var x = customers[i].firstname.indexOf(str, 0);
////        if (x = -1)

////    }
////}