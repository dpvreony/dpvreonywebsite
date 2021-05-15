var gulp = require('gulp');
var uglify = require('gulp-uglify');
var concat = require('gulp-concat');
var rimraf = require("rimraf");
var merge = require('merge-stream');

// Dependency Dirs
var deps = {
    "jquery": {
        "dist/*": ""
    },
    "bootstrap": {
        "dist/**/*": ""
    },
    "@fortawesome\fontawesome-free": {
        "**/*": ""
    }
    //,
    //"cookieconsent": {
    //    "build/*": ""
    //},
    //"highlightjs": {
    //    "*.js": "",
    //    "styles/*": "styles"
    //},
    //"lodash": {
    //    "lodash*.*": ""
    //},
    //"respond.js": {
    //    "dest/*": ""
    //},
    //"tether": {
    //    "dist/**/*": ""
    //},
    //"vue": {
    //    "dist/*": ""
    //},
    //"vee-validate": {
    //    "dist/*": ""
    //},
    //"vue-resource": {
    //    "dist/*": ""
    //},
    //"@fortawesome/fontawesome-free-webfonts": {
    //    "**/*": ""
    //}
};

gulp.task("clean", function (cb) {
    return rimraf("theme/input/lib/", cb);
});

gulp.task("scripts", function () {

    var streams = [];

    for (var prop in deps) {
        console.log("Prepping Scripts for: " + prop);
        for (var itemProp in deps[prop]) {
            streams.push(gulp.src("node_modules/" + prop + "/" + itemProp)
                .pipe(gulp.dest("theme/input/lib/" + prop + "/" + deps[prop][itemProp])));
        }
    }

    return merge(streams);

});

gulp.task("default", gulp.series('clean', 'scripts'));
