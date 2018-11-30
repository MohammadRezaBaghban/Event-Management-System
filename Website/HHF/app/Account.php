<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class account extends Model
{
    protected $table="accounts";
    protected $fillable=['account_id','email','password','bank_act_nr','initial_balance','is_valid'];

}
