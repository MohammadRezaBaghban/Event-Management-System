<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class camp_spot extends Model
{
    protected $table="camp_spots";
    protected $fillable=['spot_nr','is_reserved','is_vip'];

}
