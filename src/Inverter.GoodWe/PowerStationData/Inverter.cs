﻿namespace Inverter.GoodWe.PowerStationData
{
    internal class Inverter
    {
        public string sn { get; set; }
        public Dict dict { get; set; }
        public bool is_stored { get; set; }
        public string name { get; set; }
        public float in_pac { get; set; }
        public float out_pac { get; set; }
        public float eday { get; set; }
        public float emonth { get; set; }
        public float etotal { get; set; }
        public int status { get; set; }
        public string turnon_time { get; set; }
        public string releation_id { get; set; }
        public string type { get; set; }
        public float capacity { get; set; }
        public D d { get; set; }
        public bool it_change_flag { get; set; }
        public float tempperature { get; set; }
        public string check_code { get; set; }
        public object next { get; set; }
        public object prev { get; set; }
        public Next_Device next_device { get; set; }
        public Prev_Device prev_device { get; set; }
        public Invert_Full invert_full { get; set; }
        public string time { get; set; }
        public string battery { get; set; }
        public float firmware_version { get; set; }
        public string warning_bms { get; set; }
        public string soh { get; set; }
        public string discharge_current_limit_bms { get; set; }
        public string charge_current_limit_bms { get; set; }
        public string soc { get; set; }
        public string pv_input_2 { get; set; }
        public string pv_input_1 { get; set; }
        public string back_up_output { get; set; }
        public string output_voltage { get; set; }
        public string backup_voltage { get; set; }
        public string output_current { get; set; }
        public string output_power { get; set; }
        public string total_generation { get; set; }
        public string daily_generation { get; set; }
        public string battery_charging { get; set; }
        public string last_refresh_time { get; set; }
        public string bms_status { get; set; }
        public string pw_id { get; set; }
        public string fault_message { get; set; }
        public float battery_power { get; set; }
        public string point_index { get; set; }
        public Point[] points { get; set; }
        public object backup_pload_s { get; set; }
        public object backup_vload_s { get; set; }
        public object backup_iload_s { get; set; }
        public object backup_pload_t { get; set; }
        public object backup_vload_t { get; set; }
        public object backup_iload_t { get; set; }
        public object etotal_buy { get; set; }
        public object eday_buy { get; set; }
        public object ebattery_charge { get; set; }
        public object echarge_day { get; set; }
        public object ebattery_discharge { get; set; }
        public object edischarge_day { get; set; }
        public object batt_strings { get; set; }
        public object meter_connect_status { get; set; }
        public object mtactivepower_r { get; set; }
        public object mtactivepower_s { get; set; }
        public object mtactivepower_t { get; set; }
        public bool has_tigo { get; set; }
        public bool canStartIV { get; set; }
    }
}