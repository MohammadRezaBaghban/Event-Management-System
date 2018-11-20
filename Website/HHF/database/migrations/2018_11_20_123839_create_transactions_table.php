<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateTransactionsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('transactions', function (Blueprint $table) {
            $table->increments('transaction_id');
            $table->date('date')->unique();
            $table->timestamp('time');
            $table->integer('account_id')->unsigned();
            $table->foreign('account_id')->references('account_id')->on('accounts')->onDelete('cascade');
            $table->decimal('amount');
            $table->decimal('current_balance');
            $table->enum('type',['deposit', 'food', 'items', 'loan', 'registration', 'camp']);
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
        Schema::dropIfExists('transactions');
    }
}
