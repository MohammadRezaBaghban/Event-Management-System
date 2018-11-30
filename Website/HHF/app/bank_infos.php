<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class bank_infos extends Model
{
    protected $table="bank_infos";
    protected $fillable=['bank_act_nr','holder_name'];

}
