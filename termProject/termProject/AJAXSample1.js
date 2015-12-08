
var process;



function initialize() {
    process = new MakeChange();
 

}
function MakeChange()
{
    this.makeRequest = function (dname) {

        var content = "empty";

        var request;
        request = new XMLHttpRequest();
        

        request.onreadystatechange = function () {
            if ((request.readyState == 4) && (request.status == 200)) {
                content = request.responseText;
            }
        }

        request.open("GET", dname, false);
        request.send(null);

        return content;
    }
}