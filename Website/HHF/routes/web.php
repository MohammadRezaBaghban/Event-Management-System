<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

Route::get('/', function () {
    return view('welcome');
});

Route::get('/schedule', function () {
    return view('schedule');
});

Route::get('/booking', function () {
    return view('booking');
});

Route::get('/info', function () {
    return view('phpinfo');
});
Route::get('twitterUserTimeLine', 'TwitterController@twitterUserTimeLine');
Route::post('tweet', ['as'=>'post.tweet','uses'=>'TwitterController@tweet']);


Route::post('/save','AccountController@store');

Auth::routes();

Route::get('/home', 'HomeController@index')->name('home');