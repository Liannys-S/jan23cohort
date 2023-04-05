<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<!-- for forms -->
<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix = "fmt" uri = "http://java.sun.com/jsp/jstl/fmt" %>
<!-- for validation -->
<%@ page isErrorPage="true" %>
<!DOCTYPE html>
<html>
<head>
<!-- for Bootstrap CSS -->
<link rel="stylesheet" href="/webjars/bootstrap/css/bootstrap.min.css" />
<!-- YOUR own local CSS -->
<link rel="stylesheet" type="text/css" href="/css/style.css">
<!-- For any Bootstrap that uses JS -->
<script src="/webjars/bootstrap/js/bootstrap.min.js"></script>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<div class="container mt-5">
        <div class="row d-flex align-items-center">
                    <h1 class="display-3 text-primary col-8">Expense Details</h1>
                    <a class="col" href="/">Go back</a>
        </div>
        <div class="row fs-4 mt-5">
            <p class="col-4">Expense Name:</p>
            <p class="col">${expense.name}</p>
        </div>
        <div class="row fs-4 mt-5">
            <p class="col-4">Expense Description:</p>
            <p class="col">${expense.description}</p>
        </div>
        <div class="row fs-4 mt-5">
            <p class="col-4">Vendor:</p>
            <p class="col">${expense.vendor}</p>
        </div>
        <div class="row fs-4 mt-5">
            <p class="col-4">Amount Spent:</p>
            <p class="col"><fmt:formatNumber value ="${expense.amount}" type="currency"/></p>
        </div>
	</div>
</body>
</html>