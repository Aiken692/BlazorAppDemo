function callMethod() {
    DotNet.invokeMethodAsync("BlazorAppDemo", "GetValueFromMethod").then(result => {
        alert('Message from Method: ' + result);
    });
}