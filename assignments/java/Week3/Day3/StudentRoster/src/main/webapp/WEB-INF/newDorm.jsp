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
	<div class="container my-5 fs-4">
        <h1 class="display-3">New Dorm</h1>
		<a href="/">Dashboard</a>

        <form:form action="/dorms/create" method="post" modelAttribute="dorm" class="mt-5">
            <div class="mb-3 col-4">
                <form:label class="form-label" path="name">Name:</form:label>
                <form:input class="form-control" path="name"/>
                <form:errors class="text-danger" path="name"/>
            </div>
            <button class="btn btn-primary mt-3 ">Add</button>
        </form:form>
	</div>
</body>
</html>