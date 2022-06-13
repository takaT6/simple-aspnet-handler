# SimpleAspNetHandler_ASP.NET

JavaScriptからのAjaxなどのHTTPハンドラのテンプレート。
ジェネリックハンドラーとASP.NETハンドラーの違いは
・前者が「.ashx + .ashx.cs」で、後者が「.cs」ファイルのみで構成できる
・前者はWeb.Configへのハンドラーの登録が不必要で、後者は登録が必要
・前者は.ashxに直接アクセスするのに対し、後者は複数のURLからアクセスできる
