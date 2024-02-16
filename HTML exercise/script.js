//Es 3
function DeleteContent(){
    var h1s = document.getElementsByTagName("h1");
    for(var i = 0; i < h1s.length; i++)
    {
        h1s[i].innerText = "";
    }
/* var h1s = document.querySelectorAll("h1");
    for(var i = 0; i < h1s.length; i++)
    {
        h1s[i].innerText = "";
    }    */
}
function DivRed(){
    var div = document.getElementById("primoElementoDiv");
    div.style.color = "red";
}
function ChangeABC(){
    document.getElementById("secondoElementoDiv").innerText = "abc";
}

//Es 2
function CheckPassword(){

    if(document.getElementById("password").value == document.getElementById("passwordNuova").value){
        var PasswordCheckP = document.getElementById("PasswordCheckP");
        PasswordCheckP.innerText = "Le password sono analoghe";
        PasswordCheckP.style = "color: green;"
    }
    else
    {
        var PasswordCheckP = document.getElementById("PasswordCheckP");
        PasswordCheckP.innerText = "Le password sono diverse";
        PasswordCheckP.style = "color: red;"
    }
}

//Es 3
function GenerateTable(){
    var existingTable = document.querySelector('table')
    if(existingTable)
    {
        existingTable.remove();
    }
    var max = 30;
    var min = 10;
    var col = Math.floor(Math.random() * (max - min) ) + min;
    var row = Math.floor(Math.random() * (max - min) ) + min;
    var table = document.createElement('table');
    for(var i = 0; i < row; i++){
        table.insertRow()
        for(var j = 0; j < col; j++){
            table.rows[i].insertCell();
            var cell = table.rows[i].cells[j];
            cell.onclick = function (){
                if(cell.backgroundColor == "white"){
                    cell.backgroundColor = "black";
                }
                else{
                    cell.backgroundColor = "white";
                }
            };
            cell.style.width = "20px";
            cell.style.height = "20px";
            cell.style.borderColor = "black";
            
            if((j + i )% 2 == 0){
                cell.style.backgroundColor = "black"
            }
            else{
                cell.style.backgroundColor = "white"
            }
        }
    }
    document.body.appendChild(table)
}
