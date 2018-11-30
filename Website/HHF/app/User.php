<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class user extends Model
{
    protected $table="users";
    protected $fillable = [
        'user_id','fname','lname','account_id','phone_nr','group_id','is_admin','status','is_vip'
    ];


}
