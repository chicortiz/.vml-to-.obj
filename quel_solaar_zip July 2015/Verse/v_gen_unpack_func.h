extern unsigned int v_unpack_connect(const char *data, size_t length);
extern unsigned int v_unpack_connect_accept(const char *data, size_t length);
extern unsigned int v_unpack_connect_terminate(const char *data, size_t length);
extern unsigned int v_unpack_ping(const char *data, size_t length);
extern unsigned int v_unpack_packet_ack(const char *data, size_t length);
extern unsigned int v_unpack_packet_nak(const char *data, size_t length);
extern unsigned int v_unpack_node_index_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_node_create(const char *data, size_t length);
extern unsigned int v_unpack_node_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_tag_group_create(const char *data, size_t length);
extern unsigned int v_unpack_tag_group_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_tag_create(const char *data, size_t length);
extern unsigned int v_unpack_node_name_set(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_pos_real32(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_rot_real32(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_scale_real32(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_pos_real64(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_rot_real64(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_scale_real64(const char *data, size_t length);
extern unsigned int v_unpack_o_transform_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_o_light_set(const char *data, size_t length);
extern unsigned int v_unpack_o_link_set(const char *data, size_t length);
extern unsigned int v_unpack_o_method_group_create(const char *data, size_t length);
extern unsigned int v_unpack_o_method_group_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_o_method_create(const char *data, size_t length);
extern unsigned int v_unpack_o_method_call(const char *data, size_t length);
extern unsigned int v_unpack_o_anim_run(const char *data, size_t length);
extern unsigned int v_unpack_o_hide(const char *data, size_t length);
extern unsigned int v_unpack_g_layer_create(const char *data, size_t length);
extern unsigned int v_unpack_g_layer_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_g_vertex_set_xyz_real32(const char *data, size_t length);
extern unsigned int v_unpack_g_vertex_set_xyz_real64(const char *data, size_t length);
extern unsigned int v_unpack_g_vertex_set_uint32(const char *data, size_t length);
extern unsigned int v_unpack_g_vertex_set_real64(const char *data, size_t length);
extern unsigned int v_unpack_g_vertex_set_real32(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_corner_uint32(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_corner_real64(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_corner_real32(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_face_uint8(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_face_uint32(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_face_real64(const char *data, size_t length);
extern unsigned int v_unpack_g_polygon_set_face_real32(const char *data, size_t length);
extern unsigned int v_unpack_g_crease_set_vertex(const char *data, size_t length);
extern unsigned int v_unpack_g_crease_set_edge(const char *data, size_t length);
extern unsigned int v_unpack_g_bone_create(const char *data, size_t length);
extern unsigned int v_unpack_m_fragment_create(const char *data, size_t length);
extern unsigned int v_unpack_b_dimensions_set(const char *data, size_t length);
extern unsigned int v_unpack_b_layer_create(const char *data, size_t length);
extern unsigned int v_unpack_b_layer_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_b_tile_set(const char *data, size_t length);
extern unsigned int v_unpack_t_language_set(const char *data, size_t length);
extern unsigned int v_unpack_t_buffer_create(const char *data, size_t length);
extern unsigned int v_unpack_t_buffer_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_t_text_set(const char *data, size_t length);
extern unsigned int v_unpack_c_curve_create(const char *data, size_t length);
extern unsigned int v_unpack_c_curve_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_c_key_set(const char *data, size_t length);
extern unsigned int v_unpack_a_buffer_create(const char *data, size_t length);
extern unsigned int v_unpack_a_buffer_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_a_block_set(const char *data, size_t length);
extern unsigned int v_unpack_a_stream_create(const char *data, size_t length);
extern unsigned int v_unpack_a_stream_subscribe(const char *data, size_t length);
extern unsigned int v_unpack_a_stream(const char *data, size_t length);
