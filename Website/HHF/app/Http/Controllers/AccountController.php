<?php

namespace App\Http\Controllers;

use App\Account;
use App\User;
use App\Ticket;
use App\Transaction;
use App\CampReservation;
use App\BankInfo;
use App\CampSpot;
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
        $this->validate($request,[
            'fname1'=>'required',
            'lname1'=>'required',
            'email1'=>'required',
            'email2'=>'required',
            'passwd1'=>'required',
            'passwd2'=>'required',
            'withvip'=>'required',
            'phonenr'=>'required',
            'iban'=>'required',
            'campspotnr'=>'required',
            'camppay'=>'required',
            'fname[]'=>'required',
            'lname[]'=>'required',
            'phone[]'=>'required',
            'initialbal'=>'required'
        ]);


        $is_valid="yes";
        $store_group = new Account;
        $store_group->email             =$request->email1;
        $store_group->password          =$request->passwd1;
        $store_group->is_valid          =$is_valid;
        $store_group->bank_account_nr   =$request->iban;
        $store_group->initial_balance   =$request->initialbal;

        if($store_group->save())
            $item=$request->get('account_id');
            $users = new User;
            $act_id = DB::table('accounts')
                ->where('accounts.account_id',$item);
            $grp_id= generateGroupId();
            $is_admin="yes";
            $status=null;
            $is_vip="no";

            $users->fname =$request->fname1;
            $users->lname =$request->lname1;
            $users->phone_nr =$request->phonenr;
            $users->account_id = $act_id;
            $users->group_id = $this->$grp_id;
            $users->is_admin =$is_admin;
            $users->status =$status;
            $users->is_vip =$is_vip;
            foreach ($request as $key){
            $data = array (
                'fname'=>$request->fname->fname[$key],
                'lname'=>$request->lname->lname[$key],
                'phone'=>$request->phone_nr->phone[$key],
            );
            User::insert($data);
            }
    }

    function generateGroupId(){
        $getMaxId = "Select MAX(group_id) from users";
        $returned= $getMaxId+1;
        return $returned;
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
