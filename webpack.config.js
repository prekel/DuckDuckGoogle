var path = require("path");

module.exports = {
    mode: "development",
    entry: "./src/DuckDuckGoogle.fsproj",
    output: {
        path: path.join(__dirname, "./dist"),
        filename: "bundle.js",
    },
    devtool: "eval-source-map",
    module: {
        rules: [{
            test: /\.fs(x|proj)?$/,
            use: {
                loader: "fable-loader",
                options: {
                    define: ["DEBUG"]
                }
            }
        }]
    }
}
