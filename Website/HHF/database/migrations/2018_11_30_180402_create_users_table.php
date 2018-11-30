<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateUsersTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('users', function (Blueprint $table) {
            $table->increments('user_id');
            $table->string('fname');
            $table->string('lname');
            $table->integer('account_id')->unsigned();
            $table->foreign('account_id')->references('account_id')->on('accounts')->onDelete('cascade');
            $table->string('phone_nr');
            $table->integer('group_id')->nullable();
            $table->enum('is_admin',['yes','no']);
            $table->enum('status',['yes','no']);
            $table->enum('is_vip',['yes','no'])->nullable();
            $table->rememberToken();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('users');
    }
}
