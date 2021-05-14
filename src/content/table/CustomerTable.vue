<template>
  <div class="container-table">
    <table>
      <thead>
        <tr>
          <th></th>
          <th>Mã khách hàng</th>
          <th>Họ và tên</th>
          <th>Giới tính</th>
          <th>Ngày sinh</th>
          <th>Số diện thoại</th>
          <th>Email</th>
          <th>Mã thẻ thành viên</th>
          <th>Mã số thuế</th>
          <th>Địa chỉ</th>
          <th>Công ty</th>
        </tr>
      </thead>
      <tbody>
        <tr
          v-for="(customer, index) in listCustomer"
          :key="index"
          @dblclick="showDialog(customer)"
          :infoCustomer="customer.customerCode"
          :name="customer.fullname"
        >
          <td>
            <input type="checkbox" value="" class="checkboxRow"/>
          </td>
          <td>{{ customer.customerCode }}</td>
          <td>{{ customer.fullname }}</td>
          <td>
            {{ customer.gender | formatGender }}
          </td>
          <td>
            {{ customer.birthday | formatDate }}
          </td>
          <td>{{ customer.phone }}</td>
          <td>{{ customer.email }}</td>
          <td>
            {{ customer.memberCardCode }}
          </td>
          <td>{{ customer.taxCode }}</td>
          <td>{{ customer.address }}</td>
          <td>{{ customer.company }}</td>
        </tr>
      </tbody>
    </table>
  </div>
</template>

<script>

export default {
  name: "customertable",
  components: {},
  data() {
    return {
      listCustomer: null,
      customer: {},
      isSelected: false,
    };
  },

  mounted() {
    // axios
    //   .get("https://localhost:44333/api/Customers")
    //   .then((response) => {
    //     this.listCustomer = response.data;
    //   })
    //   .catch((e) => {
    //     alert(e);
    //   });
    this.axios('/api/Customers')
    .then((response) => {
        console.log(response);
        this.listCustomer = response.data;
      })
  },

  methods: {
    showDialog(val) {
      this.$emit("updateCustomerInTable", val);
    },
  },
};
</script>
<style>
.container-table {
  width: 100%;
  position: relative;
  height: 690px;
  overflow-y: auto;
  margin-top: 10px;
}
.container-table::-webkit-scrollbar {
  background-color: #d2d2d2;
  width: 6px;
  height: 10px;
}
.container-table::-webkit-scrollbar-thumb {
  border-top-right-radius: 6px;
}
table {
  width: 100%;
  border-spacing: 0;
}
tr:nth-child(even) {
  background-color: #fafafa;
}
tr {
  text-align: center;
  height: 40px;
}
tr:hover td {
  background-color: rgb(243, 235, 235);
}
.container-table thead th {
  position: sticky;
  top: 0;
  background-color: #ffffff;
}
th,
td {
  border-bottom: 1px solid #ddd;
}
/**Them class khi click vao 1 dong */
.selected {
  background-color: #c5c1ad;
}

.checkboxRow {
  margin-top: 5px;
  width: 18px;
  height: 18px;
}
.checkboxRow:checked {
  background-color: #019160;
}
</style>
