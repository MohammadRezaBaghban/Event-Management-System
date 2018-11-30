<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class ticket extends Model
{
    protected $table="tickets";
    protected $fillable=['ticket_id','user_id','date_of_purchase'];

}
