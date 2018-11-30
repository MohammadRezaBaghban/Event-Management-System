<?php

use Illuminate\Support\Facades\Schema;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Database\Migrations\Migration;

class CreateCampReservationsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('camp_reservations', function (Blueprint $table) {
            $table->integer('spot_nr')->unsigned();
            $table->foreign('spot_nr')->references('spot_nr')->on('camp_spots')->onDelete('cascade');
            $table->integer('account_id')->unsigned();
            $table->foreign('account_id')->references('account_id')->on('accounts')->onDelete('cascade');
            $table->enum('is_paid',['no', 'yes'])->default('no');
            $table->primary(['spot_nr', 'account_id']);
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
        Schema::dropIfExists('camp_reservations');
    }
}
