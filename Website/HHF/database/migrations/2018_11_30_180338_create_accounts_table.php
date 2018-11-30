<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateAccountsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('accounts', function (Blueprint $table) {
            $table->increments('account_id');
            $table->string('email')->unique();
            $table->string('password');
            $table->integer('bank_act_nr')->unsigned();
            $table->foreign('bank_act_nr')->references('bank_act_nr')->on('bank_infos')->onDelete('cascade');
            $table->decimal('initial_balance');
            $table->enum('is_valid',['yes','no']);
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
        Schema::dropIfExists('accounts');
    }
}
