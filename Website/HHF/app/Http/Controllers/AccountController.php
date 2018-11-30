<?php

namespace App\Http\Controllers;

use DB;
use App\account;
use App\user;
use App\ticket;
use App\transaction;
use App\camp_reservation;
use App\bank_infos;
use App\camp_spot;
use Illuminate\Support\Facades\Input;
use Illuminate\Http\Request;

class AccountController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        //
    }

    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        //
    }

    /**
     * Store a newly created resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @return \Illuminate\Http\Response
     */
    public function store(Request $request)
    {
        $store_bank_info = new bank_infos;
        $store_bank_info->holder_name =$request->fname1;
        $store_bank_info->save();

        $getBankid="SELECT MAX(bank_act_nr) FROM bank_infos";
        
        $store_group = new account;
        $store_group->email             =$request->email1;
        $store_group->password          =$request->passwd1;
        $store_group->bank_act_nr       =$getBankid;
        $store_group->initial_balance   =$request->initialbal;
        $store_group->save();

    }

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        //
    }

    /**
     * Update the specified resource in storage.
     *
     * @param  \Illuminate\Http\Request  $request
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function update(Request $request, $id)
    {
        //
    }

    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        //
    }
}
