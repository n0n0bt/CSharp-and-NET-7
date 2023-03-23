HttpClient client = new();

HttpResponseMessage response =
    await client.GetAsync("http://www.kupinarati.mk/");
WriteLine(response);

WriteLine("KupiNaRati home page has {0:N0} bytes.",
    response.Content.Headers.ContentLength);