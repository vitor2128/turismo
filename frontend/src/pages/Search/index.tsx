import React, { useState, useEffect } from "react";
import { Link } from "react-router-dom";

import api  from "../../services/api";
import CardList from "../../components/List/List";
import Pagination from "../../components/Pagination";

import { Container, Header, InputContainer } from "./styled";


const PageMain: React.FC = () => {
  const [attractions, setAttractions] = useState([]);
  const [search, setSearch] = useState("");
  const [total, setTotal] = useState(0);
  const [limit, setLimit] = useState(5);
  const [pages, setPages] = useState<any[]>([]);
  const [currentPage, setCurrentPage] = useState(1);

  //#region Busca pontos turisticos e paginação
  useEffect(() => {
    const params: any = {};
    if (search.length > 1) {
      params.search = search;
      try {
        api
          .get(`/PontosTuristicos/search`, {
            params,
          })
          .then((response) => {
            setAttractions(response.data);
            setTotal(response.headers["x-total-registros"])
          });
      } catch (error) {}
    } else {
      try {
        api
          .get(
            `/PontosTuristicos?PageNumber=${currentPage}&PageSize=${limit}`
          )
          .then((response) => {
            setAttractions(response.data);
            setTotal(response.headers["x-total-registros"])
          });
      } catch (error) {}
    }

    const totalPages = Math.ceil(total / limit);

    const arrayPages = [];
    for (let i = 1; i <= totalPages; i++) {
      arrayPages.push(i);
    }

    setPages(arrayPages);
  }, [search, currentPage, limit, total]);
  //#endregion

  return (
    <Container>
      <Header>
        <h1>LOGO</h1>
        <Link to="/create">Cadastrar novo ponto turistico</Link>
      </Header>
      <InputContainer>
        <input
          type="search"
          className="promotion-search__input"
          placeholder="Buscar"
          value={search}
          onChange={(ev) => setSearch(ev.target.value)}
        />
      </InputContainer>

      {attractions.length > 0 ? (
        <>
          <CardList attractions={attractions} />
          <Pagination
            currentPage={currentPage}
            pages={pages}
            setCurrentPage={setCurrentPage}
            setLimit={setLimit}
            total={total}
          />
        </>
      ) : (
        <h1>Resultado não encontrado</h1>
      )}
    </Container>
  );
};

export default PageMain;
